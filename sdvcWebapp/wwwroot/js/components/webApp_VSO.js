import React from 'react';
import KW from '../containers/webApp_Keyword_Container';

function VSO(props) {
	return (
		<div className="vso-top" onClick={props.onClick} id={props.vsoInfo.id}>
			<img src={props.vsoInfo.pic} alt={props.vsoInfo.name} />
			<div className="vso-container seventy">
				<h2>{props.vsoInfo.name}</h2>
				<div>{props.vsoInfo.rating}</div>
				<p>{props.vsoInfo.headline}</p>
			</div>
		</div>
	);
}

module.exports = VSO;
