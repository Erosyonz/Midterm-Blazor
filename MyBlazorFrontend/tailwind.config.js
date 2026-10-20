/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./wwwroot/index.html",
    "./Components/**/*.razor",
    "./**/*.razor",
    "./**/*.cshtml"
  ],
  theme: { extend: {} },
  plugins: []
};
