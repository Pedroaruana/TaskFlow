import rateLimit from "express-rate-limit";

const isProduction = process.env.NODE_ENV
export const authLimiter = rateLimit({
  windowMs: 15 * 60 * 1000,
  max: isProduction? 50 : 5,
  standardHeaders: true,
  legacyHeaders: false,
});
