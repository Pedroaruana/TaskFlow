import { describe, it, expect, beforeEach, beforeAll, afterAll, vi } from 'vitest'
import supertest from 'supertest'
import app from '../../src/server'
import User from '../../src/models/user.model'
import bcrypt from 'bcrypt'
 
describe('Auth login', () => { 
    const user = {
        email:'lorem@gmail.com',
        password:'a'.repeat(8),
        name:'loreme'
    }
    afterAll(async()=>{
        await User.destroy({where:{ }})
    })
    beforeAll(async()=>{
        await User.destroy({where:{}})
        const password = await bcrypt.hash(user.password, 10)
        await User.create({ ...user, password })
       
    })
    it('should log in a user with valid credentials', async () => {
        const response = await supertest(app)
            .post('/api/auth/login')
            .send({
                email: user.email,
                password: user.password,
            })

        expect(response.status).toEqual(200)
        expect(response.body).toMatchObject({
            csrfToken: expect.any(String),
            error: null,
            data: expect.any(Object),
        })
        expect(response.body.data).toMatchObject({
            id: expect.any(Number),
            name: expect.any(String),
            email: expect.any(String),
            avatar: expect.any(String),
        })
        expect(response.headers['set-cookie']).toBeDefined();
    })

    it('should return invalid credentials for an unknown user', async () => {
      
        const response = await supertest(app)
            .post('/api/auth/login')
            .send({
                email: 'lucas@gmail.com',
                password: '1'.repeat(8),
            })

        expect(response.body.error).toEqual('Invalid credentials')
        expect(response.status).toEqual(401)
    }) 
     it('should return invalid credentials for a wrong password', async () => {
       
        const response = await supertest(app)
            .post('/api/auth/login')
            .send({
                email:user.email,
                password: '14'.repeat(8),
            })

        expect(response.body.error).toEqual('Invalid credentials')
        expect(response.status).toEqual(401)
    }) 
})

describe('Auth login db error', () => { 
    const user = {
        email:'lorem@gmail.com',
        password:'a'.repeat(8),
        name:'loreme'
    }
    it('should return an internal server error when an error occurs while finding the user', async () => {
        vi.spyOn(User,'findOne').mockRejectedValue(new Error(""))
        const response = await supertest(app)
            .post('/api/auth/login')
            .send({
                email: user.email,
                password: user.password,
            })

        expect(response.status).toEqual(500)
        expect(response.body.error).toEqual("Internal server error")

        expect(response.body.datas).not.toBeDefined()
        expect(response.headers['set-cookie']).not.toBeDefined();
    })
})