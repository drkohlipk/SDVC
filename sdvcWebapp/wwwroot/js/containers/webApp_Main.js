import React from 'react';
import ReactDOM from 'react-dom';
import Button from './webApp_Button_Container';
import Search from './webApp_Search_Container';
import HeadLine from './webApp_Headline_Container';
import VSO from './webApp_VSO_Container';

var Main = React.createClass({
	render: function () {
		if (this.props.buttons) {
			return (
				<div className="center ninety">
					<HeadLine setHL={this.props.setHL}>{this.props.nav}</HeadLine>
					<Button 
						nav={this.props.nav}
						obj={this.props.obj} 
						setObj={this.props.setObj} 
						addNav={this.props.addNav}
						getVSO={this.props.getVSO}
					/>
					<hr />
					<Search />
				</div>
			);
		} else {
			return (
				<div className="center ninety">
					<HeadLine setHL={this.props.setHL}>{this.props.nav}</HeadLine>
					<VSO 
						obj={this.props.obj} 
						setObj={this.props.setObj} 
						addNav={this.props.addNav}
						getVSO={this.props.getVSO}
						VSOObj={this.props.VSOResult}
					/>
				</div>
			);
		}
	}
})

module.exports = Main;
