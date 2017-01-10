import React from 'react';

function Button(props) {
	if (props.nav.length === 0) {
		return (
			<div id="btn-hldr">
				<button className="btn btn-pop" onClick={props.onClick} value={props.val}>{props.children}</button>
				<span className="info">&#8505;<span className="hoverable">{props.desc}</span></span>
			</div>
		);
	} else {
		return (
			<div id="btn-hldr">
				<button className="btn btn-pop" onClick={props.onClick} value={props.val} style={{marginLeft : 0}}>{props.children}</button>
			</div>
		);
	}
}

module.exports = Button;
