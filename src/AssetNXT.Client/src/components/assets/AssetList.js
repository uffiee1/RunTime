import React, { Component } from 'react';
import { Container, Row, Col } from 'reactstrap';

import './Asset.css'
import './AssetList.css'
import './AssetListItem.css'

import { AssetListItem } from './AssetListItem';

export class AssetList extends Component {

  constructor(props) {
    super(props);
    this.assetHandler = this.assetHandler.bind(this);
  }

  assetHandler(assetState) {
    this.props.onAssetClicked(assetState);
  }

  render() {
    return(
      <Container className="asset-list-container">
        <Row className="asset-list-row">
          <Col className="asset-list-column">

            {this.props.tags.map(tag => 
               <AssetListItem name={tag.name}
               description={tag.description}
               position={tag.position}
               onAssetClicked={this.assetHandler}/>
            )}

          </Col>
        </Row>
      </Container>
    );
  }
}