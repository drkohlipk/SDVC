import React from 'react';

function Headline(props) {
	var navig = props.children.map(function(key, i) {
		return (
			<span key={key}><span className="linkify" onClick={() => props.onClick(i)} key={key}>{key}</span>&nbsp;&gt;&nbsp;</span>
		);
	});
	return (
		<div id="headline" className="ninety center">
			<h1 className="center">What can we help you with today?</h1>
			<p>{navig}</p>
		</div>
	);
}

module.exports = Headline;
