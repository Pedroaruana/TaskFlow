import jwt from "jsonwebtoken";
import "dotenv/config";
import { TokenPayload } from "../middlewares/auth.middleware";

export const createJsonWebToken = (payload: TokenPayload) => {

  return jwt.sign(payload, process.env.JSONWEBTOKEN_SECRET!,{
    expiresIn: "1d"
  });
};
export const readJsonWebToken = (hash: string) => {
  return jwt.verify(hash, process.env.JSONWEBTOKEN_SECRET!) ;
};
