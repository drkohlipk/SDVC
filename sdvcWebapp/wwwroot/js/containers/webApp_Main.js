import React from 'react';
import ReactDOM from 'react-dom';
import Button from './webApp_Button_Container';
import Search from './webApp_Search_Container';

var Main = React.createClass({
	render: function () {
		return (
			<div className="center ninety">
				<h1 className="center">What can we help you with today?</h1>
				<Button 
					obj={this.props.obj} 
					setObj={this.props.setObj} 
				/>
				<hr />
				<Search />
			</div>
		);
	}
})

module.exports = Main;
