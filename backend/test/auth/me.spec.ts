import { describe, it, expect, beforeEach, beforeAll, afterAll } from 'vitest'
import request from 'supertest'
import app from '../../src/server'
import User from '../../src/models/user.model'
import bcrypt from 'bcrypt'
   
describe('Auth me', () => {
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
    it('should return the authenticated user successfully', async () => {
        const agent = request.agent(app);

     
        const loginResponse = await agent
        .post('/api/auth/login')
        .send({
            email: user.email,
            password: user.password
        });
        
        expect(loginResponse.status).toBe(200);
     

        const response = await agent
        .get('/api/auth/me')
        .set('x-csrf-token', loginResponse.body.csrfToken);

        expect(response.status).toBe(200);
      
 
        expect(response.status).toEqual(200)
        expect(response.body).toMatchObject({
            error: null,
            data: expect.any(Object),
        })
        expect(response.body.data).toMatchObject({
            id: expect.any(Number),
            name: expect.any(String),
            email: expect.any(String),
            avatar: expect.any(String),
        }) 
       
    })  
     it('should return an error when the user is not logged in', async () => {
        const agent = request.agent(app);

        const response = await agent
        .get('/api/auth/me')
    
        expect(response.status).toBe(401);
        expect(response.body).not.toHaveProperty('data')
       
    })
})