import React from 'react';
import ReactDOM from 'react-dom';
import Header from '../components/webApp_Header';
import Main from './webApp_Main';
import Footer from '../components/webApp_Footer';

let emergency = ["911", "Suicidal Thoughts", "Emergency Counseling"];

var WebAssistant = React.createClass({
	getInitialState: function() {
		return { 
			KWobj : '',
			currObj : '',
			VSOResult : '',
			nav : [],
			buttons : true
	 	};
	},

	XHR: function(file, callback){
		var xhr = new XMLHttpRequest();
		xhr.onreadystatechange = function(){
			if(xhr.readyState === 4 && xhr.status === 200){
				callback(xhr.responseText);
			}
		}
		xhr.open('GET', file, true);
		xhr.send();
	},

	loadKWFromServer: function() {
		this.XHR('/js/AG_Keywords.json', function(response) {
			var obj = JSON.parse(response);
			this.setState({
				KWobj : obj,
				currObj : obj
			});
		}.bind(this));
	},

	searchAgain: function() {
		var obj = this.state.KWobj;
		this.setState({
			currObj : obj,
			VSOResult : '',
			nav : [],
			buttons : true
		});
	},

	setCurrObj: function(obj) {
		this.setState({
			currObj : obj
		});
	},

	addNav: function(kw) {
		var arr = this.state.nav;
		arr.push(kw);
		this.setState({
			nav : arr
		});
	},

	useHL: function(idx) {
		var arr = this.state.nav,
			obj = this.state.KWobj;
		arr.length = idx + 1;
		arr.forEach(function(kw) {
			obj = obj[kw];
		});
		this.setCurrObj(obj);
		this.setState({
			nav : arr,
			buttons : true
		});
	},

	goBack: function() {
		var arr = this.state.nav,
			obj = this.state.KWobj;
		arr.pop();
		arr.forEach(function(kw) {
			obj = obj[kw];
		});
		this.setCurrObj(obj);
		this.setState({
			nav : arr,
			buttons : true
		});
	},

	showVSO: function() {
		this.XHR('/js/TestVSO.json', function(response) {
			var obj = JSON.parse(response);
			this.setState({
				VSOResult : obj,
				buttons : false
			});
		}.bind(this));
	},

	componentWillMount: function() {
		this.loadKWFromServer();
	},

	render: function() {
		return (
			<div>
				<Header />
				<div className="sep"></div>
				<Main
					setHL={this.useHL}
					obj={this.state.currObj}
					nav={this.state.nav}
					setObj={this.setCurrObj}
					addNav={this.addNav}
					getVSO={this.showVSO}
					buttons={this.state.buttons}
					VSOResult={this.state.VSOResult}
				/>
				<Footer
					nav={this.state.nav} 
					goBack={this.goBack}
					getVSO={this.showVSO}
					top={this.searchAgain}
					buttons={this.state.buttons}
				/>
			</div>
		);
	}
});

ReactDOM.render( <WebAssistant url="/getKW"/> , document.getElementById('app'));
