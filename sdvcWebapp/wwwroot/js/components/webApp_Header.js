import React from 'react';
import ReactDOM from 'react-dom';
import Logo from './webApp_Logo';
import Exit from '../containers/webApp_Exit_Container';

function Header(props) {
	return (
		<header>
			<Logo />
			<Exit />
		</header>
	);
}

module.exports = Header;
