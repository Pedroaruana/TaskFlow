import { RequestHandler } from "express";
import { loginSchema } from "../schema/login.schema";
import { loginService } from "../service/login.service";
import {  formatUser } from "../../helpers/functions.helper";
import { generateToken } from "../../middlewares/csrf.middleware";
import { createJsonWebToken } from "../../libs/jwt";

export const loginController: RequestHandler = async (req, res, next) => {
  try {
    const data = loginSchema.parse(req.body);

    const result = await loginService(data.email, data.password);

    const token = createJsonWebToken({id:result.id});

    const userFormated = formatUser(result);

    const csrfToken = generateToken(req, res);

    res.cookie("session", token, {
      httpOnly: true,
      secure: process.env.NODE_ENV === "production",
      sameSite: "lax",
      path: "/",
      maxAge: 1000 * 60 * 60 * 24,
    });

    return res.status(200).json({
      error: null,
      data: userFormated,
      csrfToken,
    });
  } catch (error) {
    next(error);
  }
};
