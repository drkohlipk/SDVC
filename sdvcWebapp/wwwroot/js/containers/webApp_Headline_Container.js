import React from 'react';
import Headline from '../components/webApp_Headline';

var Headline_Container = React.createClass({
	getInitialState: function() {
		return null;
	},

	handleClick: function(idx) {
		this.props.setHL(idx);
	},
	
	render: function() {
		return <Headline buttons={this.props.buttons} onClick={this.handleClick}>{this.props.children}</Headline>;
	}
});

module.exports = Headline_Container;