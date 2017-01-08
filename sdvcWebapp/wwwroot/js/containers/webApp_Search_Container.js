import React from 'react';
import Search from '../components/webApp_Search';

var Search_Container = React.createClass({
	getInitialState: function() {
		return null;
	},

	handleClick: function(e) {
		return;
	},
	
	render: function() {
		return <Search onClick={this.handleClick}></Search>;
	}
});

module.exports = Search_Container;