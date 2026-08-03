import {  getUserByIdAuth } from "../../helpers/functions.helper"


export const meService = async (id:number) => {
  const user = await getUserByIdAuth(id)

 return user
}