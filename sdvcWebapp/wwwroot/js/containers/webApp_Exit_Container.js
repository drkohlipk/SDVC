import React from 'react';
import Exit from '../components/webApp_Exit';

var Exit_Container = React.createClass({
	getInitialState: function() {
		return null;
	},

	handleClick: function() {
		var app = document.getElementById('app');
		var overlay = document.getElementById('overlay');
		if(overlay.style.display == "block"){
			overlay.style.display = "none";
			app.style.display = "none";
		} else {
			overlay.style.opacity = .8;
			overlay.style.display = "block";
			app.style.display = "block";
		}
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