import React from 'react';
import ReactDOM from 'react-dom';
import Button from './webApp_Button_Container';
import Search from './webApp_Search_Container';
import HeadLine from './webApp_Headline_Container';

var Main = React.createClass({
	render: function () {
		return (
			<div className="center ninety">
				<HeadLine setHL={this.props.setHL}>{this.props.nav}</HeadLine>
				<Button 
					obj={this.props.obj} 
					setObj={this.props.setObj} 
					addNav={this.props.addNav}
				/>
				<hr />
				<Search />
			</div>
		);
	}
})

module.exports = Main;
