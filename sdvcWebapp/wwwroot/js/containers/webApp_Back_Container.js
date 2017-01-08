import React from 'react';
import Back from '../components/webApp_Back';

var Back_Container = React.createClass({
	getInitialState: function() {
		return null;
	},

	handleClick: function() {
		this.props.onClick();
	},
	
	render: function() {
		return <Back onClick={this.handleClick} />;
	}
});

module.exports = Back_Container;