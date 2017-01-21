import React from 'react';
import Exit from '../components/webApp_Exit';

var Exit_Container = React.createClass({
	getInitialState: function() {
		return null;
	},

	handleClick: function() {
		var app = document.getElementById('app');
		var overlay = document.getElementById('overlay');
		overlay.style.display = "none";
		app.style.display = "none";
	},
	
	render: function() {
		return (
			<div className="right">
				<Exit onClick={this.handleClick} />
			</div>
		);
	}
});

module.exports = Exit_Container;