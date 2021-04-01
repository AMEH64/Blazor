module.exports = {
  purge: {
    enabled: true,
    content: [
      './**/*.html',
      './**/*.razor',
      './**/*.razor.css'
    ]
  },
  darkMode: 'class', // or 'media' or 'class'
  theme: {
    extend: {},
  },
  variants: {
    extend: {},
  },
  plugins: [],
}
