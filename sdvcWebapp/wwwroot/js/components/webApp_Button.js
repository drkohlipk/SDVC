import React from 'react';

function Button(props) {
	return (
		<div id="btn-hldr">
			<button className="btn btn-pop" onClick={props.onClick} value={props.val} key={props.theKey + '_btn'}>{props.children}</button>
			<span onHover={props.onHover} key={props.theKey + '_span'}>&#8505;</span>
		</div>
	);
}

module.exports = Button;
