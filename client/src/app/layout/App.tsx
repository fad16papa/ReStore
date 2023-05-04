import { Fragment } from "react";
import Catalog from "../../features/catalog/Catalog";
import { Container, CssBaseline } from "@mui/material";
import Header from "./Header";

function App() {
  return (
    <Fragment>
      <CssBaseline />
      <Header />
      <Container>
        <Catalog />
      </Container>
    </Fragment>
  );
}

export default App;
