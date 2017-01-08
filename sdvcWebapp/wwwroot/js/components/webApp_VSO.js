import React from 'react';
import KW from '../containers/webApp_Keyword_Container';
import Stars from './webApp_Stars';

function VSO(props) {
	return (
		<div className="vso-top" onClick={props.onClick} id={props.vsoInfo.id}>
			<img src={props.vsoInfo.pic} alt={props.vsoInfo.name} />
			<div className="vso-container seventy">
				<h2>{props.vsoInfo.name}</h2>
				<Stars rating={props.vsoInfo.rating}/>
				<p>{props.vsoInfo.headline}</p>
				<KW keywords={props.vsoInfo.keywords} />
			</div>
		</div>
	);
}

module.exports = VSO;
