import React from "react";
import { Switch, Route } from "react-router-dom";
import PatchPage from "./PatchPage/PatchPage.jsx";

export default function Content() {
  return (
    <Switch>
      <Route exact path="/" component={() => <PatchPage id={1} />} />
      <Route exact path="/patches" component={PatchPage} />
      <Route exact path="/categories" component={PatchPage} />
    </Switch>
  );
}
