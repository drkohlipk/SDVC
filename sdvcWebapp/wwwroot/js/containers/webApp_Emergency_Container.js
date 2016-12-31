import React from 'react';
import Emergency from '../components/webApp_Emergency';

var Emergency_Container = React.createClass({
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
				<Emergency />
			</div>
		);
	}
});

module.exports = Emergency_Container;