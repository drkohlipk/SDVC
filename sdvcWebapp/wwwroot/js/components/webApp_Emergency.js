import React from 'react';

function Emergency(props) {
	return <span className="linkify" onClick={props.onClick}>Emergency Services</span>;
}

module.exports = Emergency;
