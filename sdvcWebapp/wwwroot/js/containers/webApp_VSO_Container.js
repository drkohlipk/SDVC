import React from 'react';
import VSO from '../components/webApp_VSO';
import KW from './webApp_Keyword_Container';

var VSO_Container = React.createClass({
	getInitialState: function() {
		return null;
	},

	handleClick: function(e) {
		return;
	},
	
	render: function() {
		var arr = this.props.VSOObj;
		var vsos = arr.map(function(key, i) {
			return (
				<div className="vso" key={key.name}>
					<VSO vsoInfo={key} onClick={this.handleClick} key={key.name} />
					<hr />
				</div>
			);
		}.bind(this));
		return (
			<div id="vso-hldr">
				{vsos}
			</div>
		);
	}
});

module.exports = VSO_Container;