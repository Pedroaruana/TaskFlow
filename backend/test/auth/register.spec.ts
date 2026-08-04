import { describe, it, expect, beforeEach, vi, afterAll, beforeAll } from 'vitest'
import supertest from 'supertest'
import app from '../../src/server'
import User from '../../src/models/user.model'
import bcrypt from 'bcrypt'
 
const user = {
    email:'lorem@gmail.com',
    password:'a'.repeat(9),
    name:'loreme'
}
describe('Auth register', () => {
   
    afterAll(async()=>{
        await User.destroy({where:{ }})
    })
    beforeEach(async()=>{
        await User.destroy({where:{}})
    })
     it('should reject registration when the email is already registered', async () => {
        await User.create(user)
        const response = await supertest(app)
            .post('/api/auth/register')
            .send({
                email: user.email,
                password: user.password,
                name:user.name
            })

        expect(response.status).toEqual(400)
        expect(response.body.error).toEqual('This email is already in use')
        expect(response.headers['set-cookie']).not.toBeDefined();

        const dbDatas =await User.findAll()
        expect(dbDatas).toHaveLength(1)
        
    }) 
      it('should reject registration when the name is invalid', async () => {
       
        const response = await supertest(app)
            .post('/api/auth/register')
            .send({
                email: user.email,
                password: user.password,
                name:'1'
            })

        expect(response.status).toEqual(400)
        expect(response.body.error).toEqual('Name is required')
        expect(response.headers['set-cookie']).not.toBeDefined();

        const dbDatas =await User.findAll()
        expect(dbDatas).toEqual([])
        
    })
     it('should reject registration when the email format is invalid', async () => {
       
        const response = await supertest(app)
            .post('/api/auth/register')
            .send({
                email: 'email',
                password: user.password,
                name:user.name
            })

        expect(response.status).toEqual(400)
        expect(response.body.error).toEqual('Invalid email address')
        expect(response.headers['set-cookie']).not.toBeDefined();

        const dbDatas =await User.findAll()
        expect(dbDatas).toEqual([])
        
    })
     it('should reject registration when the password is invalid', async () => {
       
        const response = await supertest(app)
            .post('/api/auth/register')
            .send({
                email: user.email,
                password: '13',
                name:user.name
            })

        expect(response.status).toEqual(400)
        expect(response.body.error).toEqual('The password must be at least 8 characters long.')
        expect(response.headers['set-cookie']).not.toBeDefined();

        const dbDatas =await User.findAll()
        expect(dbDatas).toEqual([])
        
    }) 
    it('should create a user with valid credentials', async () => {
        const response = await supertest(app)
            .post('/api/auth/register')
            .send({
                email: user.email,
                password: user.password,
                name:user.name
            })

        expect(response.status).toEqual(201)
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

        const dbDatas =await User.findAll()
        expect(dbDatas).toHaveLength(1)
        
        expect(dbDatas[0].name).toEqual(user.name)
        expect(dbDatas[0].email).toEqual(user.email)
        expect(await bcrypt.compare(user.password,dbDatas[0].password)).toBeTruthy()
    })
})


describe("Auth register db error",()=>{
    beforeAll(async()=>{
        await User.destroy({where:{}})
    }) 
    beforeEach(()=>{
        vi.clearAllMocks()
        vi.resetAllMocks()
    })
    afterAll(()=>{
        vi.resetAllMocks()
    })
    it('should return "Internal server error" when an error occurs while creating a user', async () => {
       vi.spyOn(User,'create').mockRejectedValueOnce(new Error(""))
        const response = await supertest(app)
            .post('/api/auth/register')
            .send({
                email: user.email,
                password: user.password,
                name:user.name
            })
            
      
        expect(response.status).toEqual(500)
        expect(response.body.error).toEqual('Internal server error')
        expect(response.headers['set-cookie']).not.toBeDefined();
            
        const dbDatas =await User.findAll()
        expect(dbDatas).toEqual([])
        
    })
     it('should return "Internal server error" when an error occurs while finding a user', async () => {
       vi.spyOn(User,'findOne').mockRejectedValue(new Error(""))
        const response = await supertest(app)
            .post('/api/auth/register')
            .send({
                email: user.email,
                password: user.password,
                name:user.name
            })
  
        expect(response.status).toEqual(500)
        expect(response.body.error).toEqual('Internal server error')
        expect(response.headers['set-cookie']).not.toBeDefined();
            
        const dbDatas =await User.findAll()
        expect(dbDatas).toEqual([])
        
    })
})