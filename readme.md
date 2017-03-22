# how to build / run
## install this shit
dotnet core
nodejs / npm

## run this shit
dotnet restore
npm install
webpack --config webpack.config.vendor.js (see https://github.com/aspnet/JavaScriptServices/issues/780)
webpack --config webpack.config.js
dotnet run