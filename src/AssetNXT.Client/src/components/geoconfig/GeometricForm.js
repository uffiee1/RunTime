import React, { Component } from "react";
import { Container, Row, Col, Form, FormGroup, Label, Input, Button } from 'reactstrap';

import './GeometricForm.css';

export default class GeometricForm extends Component {

  state = {
    position: this.props.position,
  }

  setLatitude(value) {
    this.state.position.lat = value;
    this.setState({position: this.state.position});

    if (this.props.stateHasChanged) {
      this.props.stateHasChanged(this.state);
    }
  }

  setLongitude(value) {
    this.state.position.lng = value;
    this.setState({position: this.state.position});

    if (this.props.stateHasChanged) {
      this.props.stateHasChanged(this.state);
    }
  }

  render() {
    return (
      <Form> 
        <Container fluid>
          <Row form>
            <Label for="position">Position:</Label>
          </Row>
          <Row form>
            <Col xs="auto">
              <FormGroup>
                <Input type="text" placeholder="Latitude"
                  onchange={(e) => this.setLatitude(e.target.value)}
                  value={this.props.position.lat} />
              </FormGroup>
            </Col>
            <Col xs="auto">
              <FormGroup>
                <Input type="text" placeholder="Longitude"
                  onchange={(e) => this.setLongitude(e.target.value)}
                  value={this.props.position.lng}/>
              </FormGroup>
            </Col>
          </Row>
          <Row form>
            <Label for="radius">Radius:</Label>
          </Row>
          <Row form>
            <FormGroup>
              <Input type="range" min={1} max={50} step={1}/>
            </FormGroup>
          </Row>
          <Row form>
            <FormGroup>
              <Button color={'primary'}>Add</Button>
            </FormGroup>
          </Row>
        </Container>
      </Form>
    );
  }
}