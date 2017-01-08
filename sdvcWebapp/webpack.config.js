var path = require('path');
var webpack = require('webpack');

module.exports = {
	entry: './wwwroot/js/containers/webAssistant.js',
	output: { path: './wwwroot/js/', filename: 'appbundle.js' },

	module: {
		loaders: [
			{
				test: /.jsx?$/,
				loader: 'babel-loader',
				exclude: /node-modules/,
				query: {
					presets: ['es2015', 'react']
				}
			}
		]
	}
};