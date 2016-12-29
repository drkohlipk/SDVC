import React from 'react';
import ReactDOM from 'react-dom';
import Button from './webApp_Button_Container';

var Main = React.createClass({
	render: function () {
		return (
			<main>
				<Button obj={this.props.obj} />
			</main>
		);
	}
})

module.exports = Main;
