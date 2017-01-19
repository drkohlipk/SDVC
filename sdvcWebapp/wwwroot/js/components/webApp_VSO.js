import React from 'react';
import KW from '../containers/webApp_Keyword_Container';
import Stars from './webApp_Stars';
import FaShare from 'react-icons/fa/share-alt';
import FaMobile from 'react-icons/fa/mobile';

function VSO(props) {
	return (
		<div className="vso-top" onClick={props.onClick} id={props.vsoInfo.id}>
			<div className="vsoPicSide thirty">
				<img src={props.vsoInfo.pic} alt={props.vsoInfo.name} />
				<div className="share">
					<div className="call">
						<FaMobile className="phoneIcon" size={19} color='#1d3666' />
						<a href="#" className="linkify">Call VSO now!</a>
					</div>
					<div className="shareStuff">
						<FaShare className="shareIcon" size={15} color='#1d3666' />
						<span className="linkify">Share this!</span>
					</div>
				</div>
			</div>
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
