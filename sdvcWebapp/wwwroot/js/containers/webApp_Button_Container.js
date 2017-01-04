import React from 'react';
import Button from '../components/webApp_Button';

var Button_Container = React.createClass({
	getInitialState: function() {
		return {
			bottom: false
		};
	},

	handleClick: function(e) {
		var val = e.target.value,
			newObj = this.props.obj[val];
			this.props.setObj(newObj);
			this.props.addNav(val);
	},
	
	render: function() {
		if (!Array.isArray(this.props.obj)) {
			var buttons = Object.keys(this.props.obj).map(function(key, index) {
				return (
					<Button onClick={this.handleClick} key={key} theKey={key} val={key}>{key}</Button>
				);
			}.bind(this));
		} else {
			var arr = this.props.obj;
			var buttons = arr.map(function(key, i) {
				return (
					<Button onClick={this.handleClick} key={key} theKey={key} val={key}>{key}</Button>
				);
			}.bind(this));
		}
		return (
			<div>
				{buttons}
			</div>
		);
	}
});

module.exports = Button_Container;