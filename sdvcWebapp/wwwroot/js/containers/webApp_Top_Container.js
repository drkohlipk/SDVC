import React from 'react';
import Top from '../components/webApp_Top';

var Top_Container = React.createClass({
	getInitialState: function() {
		return null;
	},

	handleClick: function() {
		this.props.onClick();
	},
	
	render: function() {
		return <Top onClick={this.handleClick} />;
	}
});

module.exports = Top_Container;