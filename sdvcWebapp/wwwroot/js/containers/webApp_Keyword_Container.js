import React from 'react';
import KW from '../components/webApp_Keyword';

var Keyword_Container = React.createClass({
	getInitialState: function() {
		return null;
	},

	handleClick: function(e) {
		var val = e.target.value,
			newObj = this.props.obj[val];
		this.props.setObj(newObj);
		this.props.addNav(val);
	},
	
	render: function() {
		var arr = this.props.keywords;
		var kws = arr.map(function(key, i) {
				return (
					<KW keyword={key} key={key.kw} />
				);
			}.bind(this));
		return (
			<div id="kw-hldr">
				{kws}
			</div>
		);
	}
});

module.exports = Keyword_Container;