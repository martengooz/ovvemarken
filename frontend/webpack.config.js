const HtmlWebPackPlugin = require("html-webpack-plugin");
const path = require("path");

module.exports = {
  entry: [
    // converted entry to an array
    // to allow me to unshift the client later
    path.resolve(__dirname, "./src/index.js"),
  ],
  module: {
    rules: [
      {
        test: /\.(js|jsx)$/,
        exclude: /node_modules/,
        use: "babel-loader",
      },
      {
        test: /\.css$/,
        use: ["style-loader", "css-loader"],
      },
      {
        test: /\.html$/,
        use: [
          {
            loader: "html-loader",
          },
        ],
      },
    ],
  },
  devServer: {
    headers: { "Access-Control-Allow-Origin": "*" },
    host: "0.0.0.0",
    port: 3000,
    proxy: {
      "/api": {
        target: "https://localhost:44394",
        secure: false,
      },
    },
  },
  plugins: [
    new HtmlWebPackPlugin({
      template: "./public/index.html",
      filename: "./index.html",
    }),
  ],
};
