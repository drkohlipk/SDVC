"use strict";

var Comment = React.createClass({
	displayName: "Comment",
	render: function render() {
		return React.createElement(
			"div",
			{ className: "comment" },
			React.createElement(
				"h2",
				{ className: "commentAuthor" },
				this.props.author
			),
			this.props.children
		);
	}
});

var CommentList = React.createClass({
	displayName: "CommentList",

	render: function render() {
		var commentNodes = this.props.data.map(function (comment) {
			return React.createElement(
				Comment,
				{ author: comment.author, key: comment.id },
				comment.text
			);
		});
		return React.createElement(
			"div",
			{ className: "commentList" },
			commentNodes
		);
	}
});

var CommentForm = React.createClass({
	displayName: "CommentForm",

	getInitialState: function getInitialState() {
		return { author: '', text: '' };
	},
	handleAuthorChange: function handleAuthorChange(e) {
		this.setState({ author: e.target.value });
	},
	handleTextChange: function handleTextChange(e) {
		this.setState({ text: e.target.value });
	},
	handleSubmit: function handleSubmit(e) {
		e.preventDefault();
		var author = this.state.author.trim();
		var text = this.state.text.trim();
		if (!text || !author) {
			return;
		}
		this.props.onCommentSubmit({ author: author, text: text });
		this.setState({ author: '', text: '' });
	},
	render: function render() {
		return React.createElement(
			"form",
			{ className: "commentForm", onSubmit: this.handleSubmit },
			React.createElement("input", {
				type: "text",
				placeholder: "Your name",
				value: this.state.author,
				onChange: this.handleAuthorChange
			}),
			React.createElement("input", {
				type: "text",
				placeholder: "Say something...",
				value: this.state.text,
				onChange: this.handleTextChange
			}),
			React.createElement("input", { type: "submit", value: "Post" })
		);
	}
});

var CommentBox = React.createClass({
	displayName: "CommentBox",

	loadCommentsFromServer: function loadCommentsFromServer() {
		var xhr = new XMLHttpRequest();
		xhr.open('get', this.props.url, true);
		xhr.onload = function () {
			var data = JSON.parse(xhr.responseText);
			this.setState({ data: data });
		}.bind(this);
		xhr.send();
	},
	handleCommentSubmit: function handleCommentSubmit(comment) {
		var data = new FormData();
		data.append('author', comment.author);
		data.append('text', comment.text);
		var xhr = new XMLHttpRequest();
		xhr.open('post', this.props.submitUrl, true);
		xhr.onload = function () {
			this.loadCommentsFromServer();
		}.bind(this);
		xhr.send(data);
	},
	getInitialState: function getInitialState() {
		return { data: [] };
	},
	componentDidMount: function componentDidMount() {
		this.loadCommentsFromServer();
		window.setInterval(this.loadCommentsFromServer, this.props.pollInterval);
	},
	render: function render() {
		return React.createElement(
			"div",
			{ className: "commentBox" },
			React.createElement(
				"h1",
				null,
				"Comments"
			),
			React.createElement(CommentList, { data: this.state.data }),
			React.createElement(CommentForm, { onCommentSubmit: this.handleCommentSubmit })
		);
	}
});

ReactDOM.render(React.createElement(CommentBox, { url: "/comments", submitUrl: "/comments/new", pollInterval: "{2000}" }), document.getElementById('content'));