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
					<HeadLine buttons={this.props.buttons} setHL={this.props.setHL}>{this.props.nav}</HeadLine>
					<Button 
						nav={this.props.nav}
						obj={this.props.obj} 
						setObj={this.props.setObj} 
						addNav={this.props.addNav}
						getVSO={this.props.getVSO}
						desc={this.props.desc}
					/>
					<hr />
					<Search getVSO={this.props.getVSO}/>
				</div>
			);
		} else {
			return (
				<div className="center ninety">
					<HeadLine buttons={this.props.buttons} setHL={this.props.setHL}>{this.props.nav}</HeadLine>
					<VSO 
						obj={this.props.obj} 
						setObj={this.props.setObj} 
						addNav={this.props.addNav}
						getVSO={this.props.getVSO}
						VSOObj={this.props.VSOResult}
					/>
					<div id="callBox">
						<h6>Still can't find what you're looking for?</h6>
						<p>Call: 858-374-5555</p>
					</div>
				</div>
			);
		}
	}
})

module.exports = Main;
