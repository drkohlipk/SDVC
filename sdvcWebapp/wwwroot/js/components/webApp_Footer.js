import React from 'react';
import ReactDOM from 'react-dom';
import Back from '../containers/webApp_Back_Container';
import Emergency from '../containers/webApp_Emergency_Container';

function Footer(props) {
	if (props.nav.length === 0) {
		return (
			<footer>
				<Emergency />
			</footer>
		);
	} else {
		return (
			<footer>
				<Back onClick={props.goBack} />
				<Emergency />
			</footer>
		);
	}
}

module.exports = Footer;
