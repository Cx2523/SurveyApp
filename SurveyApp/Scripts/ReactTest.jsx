class TestComponent extends React.Component {
    testClassMethod() {
        return 10 + 2;
    }   

    render() {
        return (
            <h1 className="commentBox">
                Hello, world! I am a REACT Component! This is a test class method {this.testClassMethod()}!
            </h1>
        );
    }
}



ReactDOM.render(<TestComponent />, document.getElementById("reactNode"));