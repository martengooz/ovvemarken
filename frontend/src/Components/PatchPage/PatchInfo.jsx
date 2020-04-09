import React, { useState, useEffect } from "react";
import Grid from "@material-ui/core/Grid";

export default function PatchInfo(props) {
  const [data, setData] = useState(props.data);
  const [patchInfo, setPatchInfo] = useState([]);

  function renderInfo() {
    const info = [];
    if (data.name) {
      info.push(
        <Grid key="name" container spacing={1}>
          <h1>{data.name}</h1>
        </Grid>
      );
    }

    if (data.creator) {
      info.push(
        <Grid key="creator" container spacing={1}>
          <h3>Skapad av {data.creator}</h3>
        </Grid>
      );
    }

    if (data.width && data.height) {
      info.push(
        <Grid key="size" container spacing={1}>
          <h3>
            {data.width} x {data.height} mm
          </h3>
        </Grid>
      );
    }

    if (data.date) {
      info.push(
        <Grid key="date" container spacing={1}>
          <h3>
            Märket är skapat {new Date(data.date).toLocaleDateString("SWE")}
          </h3>
        </Grid>
      );
    }

    setPatchInfo(info);
  }

  useEffect(() => {
    setData(props.data);
  }, [props.data]);

  useEffect(() => {
    renderInfo();
  }, [data]);

  return (
    <Grid container justify="flex-start" spacing={3}>
      <Grid item md={1} />
      <Grid item xs={12} md={11}>
        {patchInfo}
      </Grid>
    </Grid>
  );
}

PatchInfo.defaultProps = {
  data: {},
};
