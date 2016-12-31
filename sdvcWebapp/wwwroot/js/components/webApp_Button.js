import React from 'react';

function Button(props) {
	return (
		<div id="btn-hldr">
			<button className="btn btn-pop" onClick={props.onClick} value={props.val}>{props.children}</button>
			<span onHover={props.onHover}>&#8505;</span>
		</div>
	);
}

module.exports = Button;
