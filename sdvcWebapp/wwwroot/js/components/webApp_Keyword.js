import React from 'react';

function Keyword(props) {
	return (
		<div className="kw">
			<span className="endos">{props.keyword.endorsements}</span>
			<span className="kw-name">{props.keyword.kw}<span className="add">&nbsp;+</span></span>
		</div>
	);
}

module.exports = Keyword;
