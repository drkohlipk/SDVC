import React from 'react';
import Exit from '../components/webApp_Exit';

var Exit_Container = React.createClass({
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
		return (
			<div className="right">
				<Exit/>
			</div>
		);
	}
});

module.exports = Exit_Container;