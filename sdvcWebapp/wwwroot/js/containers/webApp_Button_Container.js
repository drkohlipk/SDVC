import React from 'react';
import Button from '../components/webApp_Button';

var Button_Container = React.createClass({
	getInitialState: function() {
		return null;
	},

	handleClick: function(e) {
		var val = e.target.value,
			newObj = this.props.obj[val];
		this.props.setObj(newObj);
		this.props.addNav(val);
	},

	bottomClick: function(e) {
		var val = e.target.value;
		this.props.getVSO(val);
		this.props.addNav(val);
	},
	
	render: function() {
		if (!Array.isArray(this.props.obj) && this.props.nav.length == 0) {
			var buttons = Object.keys(this.props.obj).map(function(key, index) {
				return <Button desc={this.props.desc[key]} onClick={this.handleClick} key={key} nav={this.props.nav} val={key}>{key}</Button>;
			}.bind(this));
		} else if (!Array.isArray(this.props.obj)) {
			var buttons = Object.keys(this.props.obj).map(function(key, index) {
				return <Button onClick={this.handleClick} key={key} nav={this.props.nav} val={key}>{key}</Button>;
			}.bind(this));
		} else {
			var arr = this.props.obj;
			var buttons = arr.map(function(key, i) {
				return <Button onClick={this.bottomClick} key={key} nav={this.props.nav} val={key}>{key}</Button>;
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