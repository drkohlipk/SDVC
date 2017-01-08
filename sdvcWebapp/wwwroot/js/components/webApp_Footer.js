import React from 'react';
import ReactDOM from 'react-dom';
import Back from '../containers/webApp_Back_Container';
import Top from '../containers/webApp_Top_Container';
import Emergency from '../containers/webApp_Emergency_Container';

function Footer(props) {
	if (props.nav.length === 0 && props.buttons) {
		return (
			<footer>
				<Emergency getVSO={props.getVSO}/>
			</footer>
		);
	} else if (!props.buttons) {
		return (
			<footer>
				<Top onClick={props.top} />
				<Emergency getVSO={props.getVSO}/>
			</footer>
		);
	} else {	
		return (
			<footer>
				<Back onClick={props.goBack} />
				<Emergency getVSO={props.getVSO}/>
			</footer>
		);
	}
}

module.exports = Footer;
