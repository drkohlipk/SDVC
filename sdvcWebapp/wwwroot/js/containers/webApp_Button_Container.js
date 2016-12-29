import React from 'react';
import Button from '../components/webApp_Button';

var Button_Container = React.createClass({
	getInitialState: function() {
		return null;
	},

	handleClick: function(e) {
		return;
	},

	handleHover: function(e) {
		return;
	},
	
	render: function() {
		var buttons = Object.keys(this.props.obj).map(function(key, index) {
			return (
				<Button onClick={this.handleClick} onHover={this.handleHover} val={key}>{key}</Button>
			);
		}.bind(this));
		return (
			<div>
				{buttons}
			</div>
		);
	}
});

module.exports = Button_Container;