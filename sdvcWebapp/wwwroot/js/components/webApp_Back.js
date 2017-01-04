import React from 'react';

function Back(props) {
	return <span className="left linkify" onClick={props.onClick}>&larr; Back</span>;
}

module.exports = Back;
