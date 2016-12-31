import React from 'react';
import Search_Btn from '../components/webApp_Search_Btn';

var Search_Btn_Container = React.createClass({
	getInitialState: function() {
		return null;
	},

	handleClick: function(e) {
		return;
	},
	
	render: function() {
		return <Search_Btn onClick={this.handleClick}></Search_Btn>;
	}
});

module.exports = Search_Btn_Container;