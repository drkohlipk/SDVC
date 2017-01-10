import React from 'react';
import Emergency from '../components/webApp_Emergency';

var Emergency_Container = React.createClass({
	getInitialState: function() {
		return null;
	},

	handleClick: function(e) {
		this.props.getVSO();
	},
	
	render: function() {
		return (
			<div id="emerg" className="right">
				<Emergency onClick={this.handleClick}/>
			</div>
		);
	}
});

module.exports = Emergency_Container;