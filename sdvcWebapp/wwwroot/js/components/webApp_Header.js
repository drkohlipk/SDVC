import React from 'react';
import ReactDOM from 'react-dom';
import Logo from './webApp_Logo';
import Menu_Exp from './webApp_Menu_Exp';

function Header(props) {
	return (
		<header>
			<Logo />
			<Menu_Exp />
		</header>
	);
}

module.exports = Header;
