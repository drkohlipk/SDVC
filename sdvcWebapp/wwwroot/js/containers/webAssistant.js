import React from 'react';
import ReactDOM from 'react-dom';
import Header from '../components/webApp_Header';
import Main from './webApp_Main';
import Footer from '../components/webApp_Footer';

let emergency = ["911", "Suicidal Thoughts", "Emergency Counseling"];

var WebAssistant = React.createClass({
	getInitialState: function() {
		return { 
			KWobj : 'test',
			currCat : 'test'
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
				KWobj : obj
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
				<Main obj={this.state.KWobj} />
				<Footer />
			</div>
		);
	}
});

ReactDOM.render( <WebAssistant url="/getKW"/> , document.getElementById('app'));
