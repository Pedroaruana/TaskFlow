import { describe, it, expect, beforeEach, beforeAll, afterAll, vi } from 'vitest'
import request from 'supertest'
import app from '../../src/server'
import User from '../../src/models/user.model'
import bcrypt from 'bcrypt'
 
describe('Auth forgot-password', () => { 
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
    it('should successfully send the OTP', async () => {
        
        const response = await request(app)
        .post('/api/auth/forgot-password')
        .send({email:user.email})


        expect(response.status).toEqual(200)
        expect(response.body.data).toEqual(
            expect.objectContaining({
                code_otp: expect.any(String),
                moment_expire: expect.any(Number),
                moment_generate: expect.any(String),
            }),
        );
        expect(response.body.error).toBeNull()
    })
     it('should return an error when the user does not exist', async () => {
        await User.destroy({where:{}})
        const response = await request(app)
        .post('/api/auth/forgot-password')
        .send({email:user.email})
       

        expect(response.status).toEqual(404)
        expect(response.body).not.toHaveProperty('data')
        expect(response.body.error).toEqual('Email not found.')
    })
   
})

describe('Auth forgot-password database error', () => { 
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
    it('should return an error when the database returns an error', async () => {
        
     
        vi.spyOn(User,'findOne').mockRejectedValue(new Error(""))
        const response = await request(app)
        .post('/api/auth/forgot-password')
        .send({email:user.email})
   

        expect(response.status).toEqual(500)
        expect(response.body).not.toHaveProperty('data')
        expect(response.body.error).toEqual('Internal server error')
    })
 
})