module.exports = {
  purge: [],
  darkMode: false, // or 'media' or 'class'
    theme: {
        extend: {
            backgroundImage: theme => ({
                'rocks': "url('https://i.imgur.com/4zSqPG3.png')",
            })
        },
    },
    variants: {
        extend: {
            opacity: ['disabled'],
        }
    },
    plugins: [
        require('@tailwindcss/forms'),
    ],
}
