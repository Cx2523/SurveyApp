var TestComponent = React.createClass({
    render: function () {
        return (
            <h1 className="commentBox">
                Hello, world! I am a REACT Component.
            </h1>
        );
    }
});

ReactDOM.render(<TestComponent />, document.getElementById("reactMount"));