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
		if (Array.isArray(newObj)) {
			this.setState({ bottom : true });
			this.props.setObj(newObj);
		} else {
			this.setState({ bottom : false });
			this.props.setObj(newObj);
		}
	},

	handleHover: function(e) {
		return;
	},
	
	render: function() {
		if (!this.state.bottom) {
			var buttons = Object.keys(this.props.obj).map(function(key, index) {
				return (
					<Button onClick={this.handleClick} onHover={this.handleHover} key={key} theKey={key} val={key}>{key}</Button>
				);
			}.bind(this));
		} else {
			var arr = this.props.obj;
			console.log
			var buttons = arr.map(function(key, i) {
				return (
					<Button onClick={this.handleClick} onHover={this.handleHover} key={key} theKey={key} val={key}>{key}</Button>
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