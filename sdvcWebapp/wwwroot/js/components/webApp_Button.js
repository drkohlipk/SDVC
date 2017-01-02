import React from 'react';

function Button(props) {
	return (
		<div id="btn-hldr">
			<button className="btn btn-pop" onClick={props.onClick} value={props.val} key={props.theKey + '_btn'}>{props.children}</button>
			<span className="info" key={props.theKey + '_span'}>&#8505;<span className="hoverable">Descriptive Material Here</span></span>
		</div>
	);
}

module.exports = Button;
