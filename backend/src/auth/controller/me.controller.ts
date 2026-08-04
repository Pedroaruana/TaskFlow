import {  RequestHandler } from "express";
import { meService } from "../service/me.service";


export const meController: RequestHandler = async (req, res, next) => {
  try {
   
    const user = await meService(req.user.id);
   
    return res.status(200).json({ error: null, data: user });
  } catch (error: unknown) {
    next(error);
  }
};
