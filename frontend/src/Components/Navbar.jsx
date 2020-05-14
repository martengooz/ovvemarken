import React, { useState } from "react";
import { NavLink } from "react-router-dom";
import AppBar from "@material-ui/core/AppBar";
import Toolbar from "@material-ui/core/Toolbar";
import Typography from "@material-ui/core/Typography";
import { makeStyles } from "@material-ui/core/styles";
import MenuIcon from "@material-ui/icons/Menu";
import InputBase from "@material-ui/core/InputBase";
import SearchIcon from "@material-ui/icons/Search";
import { ClickAwayListener } from "@material-ui/core";
import Drawer from "@material-ui/core/Drawer";
import List from "@material-ui/core/List";
import ListItem from "@material-ui/core/ListItem";

export default function Navbar() {
  const classes = useStyles();
  const [isInSearch, setIsInSearch] = useState(false);
  const [isMenuOpen, setIsMenuOpen] = useState(false);

  const toggleSearch = (open) => {
    setIsInSearch(open);
  };

  const toggleDrawer = (open) => (event) => {
    if (
      event.type === "keydown" &&
      (event.key === "Tab" || event.key === "Shift")
    ) {
      return;
    }
    setIsMenuOpen(open);
  };

  const desktopNavbar = (
    <AppBar className={classes.appbarDesktop} position="static">
      <Toolbar>
        <Typography className={classes.title} variant="h4" noWrap>
          <NavLink
            to="/"
            activeClassName={classes.appbarText}
            className={classes.appbarText}
          >
            OVVEMÄRKEN
          </NavLink>
        </Typography>
        <Typography className={classes.item} variant="h6" noWrap>
          <NavLink
            to="/patches"
            activeClassName={classes.appbarText}
            className={classes.appbarText}
          >
            MÄRKEN
          </NavLink>
        </Typography>
        <Typography className={classes.item} variant="h6" noWrap>
          <NavLink
            to="/categories"
            activeClassName={classes.appbarText}
            className={classes.appbarText}
          >
            KATEGORIER
          </NavLink>
        </Typography>
        <Typography className={classes.last} variant="h6" noWrap>
          <NavLink
            to="/categories"
            activeClassName={classes.appbarText}
            className={classes.appbarText}
          >
            MENY FLIK 3
          </NavLink>
        </Typography>
        <div className={classes.search}>
          <div className={classes.searchIcon}>
            <SearchIcon />
          </div>
          <InputBase
            placeholder="Sök märke..."
            classes={{
              root: classes.inputRoot,
              input: classes.inputInput,
            }}
          />
        </div>
      </Toolbar>
    </AppBar>
  );

  const mobileNavbar = (
    <div className={classes.root}>
      <AppBar className={classes.appbarMobile} position="static">
        <Toolbar className={classes.toolbarMobile}>
          <React.Fragment key="left">
            <MenuIcon
              className={classes.menuButton}
              aria-controls="menu-appbar"
              onClick={toggleDrawer(true)}
            />
            <div className={classes.drawerContainer}>
              <Drawer
                classes={{
                  paper: classes.drawerPaper,
                }}
                BackdropProps={{ invisible: true }}
                anchor={"left"}
                open={isMenuOpen}
                onClose={toggleDrawer(false)}
              >
                <List>
                  <ListItem
                    className={classes.dropdownItem}
                    onClick={toggleDrawer(false)}
                  >
                    <NavLink
                      to="/"
                      activeClassName={classes.appbarText}
                      className={classes.appbarText}
                    >
                      MÄRKEN
                    </NavLink>
                  </ListItem>
                  <ListItem
                    className={classes.dropdownItem}
                    onClick={toggleDrawer(false)}
                  >
                    <NavLink
                      to="/categories"
                      activeClassName={classes.appbarText}
                      className={classes.appbarText}
                    >
                      KATEGORIER
                    </NavLink>
                  </ListItem>
                  <ListItem
                    className={classes.dropdownItem}
                    onClick={toggleDrawer(false)}
                  >
                    <NavLink
                      to="/categories"
                      activeClassName={classes.appbarText}
                      className={classes.appbarText}
                    >
                      MENY FLIK 3
                    </NavLink>
                  </ListItem>
                </List>
              </Drawer>
            </div>
          </React.Fragment>
          {isInSearch ? (
            <ClickAwayListener onClickAway={() => toggleSearch(false)}>
              <div className={classes.search}>
                <div className={classes.searchIcon}>
                  <SearchIcon />
                </div>
                <InputBase
                  placeholder="Search…"
                  classes={{
                    root: classes.inputRoot,
                    input: classes.inputInput,
                  }}
                />
              </div>
            </ClickAwayListener>
          ) : (
            <>
              <Typography className={classes.titleMobile} variant="h5" noWrap>
                <NavLink
                  to="/"
                  activeClassName={classes.appbarText}
                  className={classes.appbarText}
                >
                  OVVEMÄRKEN
                </NavLink>
              </Typography>
              <SearchIcon
                className={classes.searchIconMobile}
                onClick={() => toggleSearch(!isInSearch)}
              />
            </>
          )}
        </Toolbar>
      </AppBar>
    </div>
  );

  return (
    <>
      {desktopNavbar}
      {mobileNavbar}
    </>
  );
}

const useStyles = makeStyles((theme) => ({
  appbarDesktop: {
    backgroundColor: "#F7F6F7",
    boxShadow: "none",
    fontFamily: "inherit",
    marginBottom: "10px",
    display: "block",
    [theme.breakpoints.down("sm")]: {
      display: "none",
    },
  },
  appbarMobile: {
    backgroundColor: "#F7F6F7",
    boxShadow: "none",
    fontFamily: "inherit",
    marginBottom: "10px",
    display: "block",
    [theme.breakpoints.up("md")]: {
      display: "none",
    },
  },
  appbarText: {
    color: "#6198AB",
    textDecoration: "none",
    verticalAlign: "middle",
  },
  toolbarMobile: {
    justifyContent: "space-between",
  },
  root: {
    flexGrow: 1,
  },
  title: {
    alignSelf: "flex-end",
    marginRight: "65px",
    marginLeft: "10px",
    [theme.breakpoints.down("md")]: {
      marginRight: "30px",
    },
  },
  titleMobile: {
    alignSelf: "flex-end",
    marginRight: "auto",
    marginLeft: "auto",
    paddingBottom: "7px",
  },
  item: {
    alignSelf: "flex-end",
    marginRight: "75px",
    [theme.breakpoints.down("md")]: {
      marginRight: "30px",
    },
  },
  last: {
    alignSelf: "flex-end",
    flexGrow: 1,
  },
  search: {
    alignSelf: "flex-end",
    position: "relative",
    borderRadius: theme.shape.borderRadius,
    border: "2px solid #6198AB",
  },
  searchIcon: {
    color: "#6198AB",
    padding: theme.spacing(0, 2),
    height: "100%",
    position: "absolute",
    pointerEvents: "none",
    display: "flex",
    alignItems: "center",
    justifyContent: "center",
  },
  searchIconMobile: {
    alignSelf: "flex-end",
    align: "right",
    color: "#6198AB",
    fontSize: "48px",
  },
  menuButton: {
    color: "#6198AB",
    alignSelf: "flex-end",
    fontSize: "48px",
  },
  inputRoot: {
    color: "#6198AB",
  },
  inputInput: {
    padding: theme.spacing(1, 1, 1, 0),
    // vertical padding + font size from searchIcon
    paddingLeft: `calc(1em + ${theme.spacing(4)}px)`,
    transition: theme.transitions.create("width"),
    width: "100%",
    [theme.breakpoints.up("sm")]: {
      width: "12ch",
      "&:focus": {
        width: "20ch",
      },
    },
  },
  drawerPaper: {
    marginTop: "66px",
    color: "#6198AB",
    backgroundColor: "#F7F6F7",
    boxShadow: "none",
  },
  dropdownItem: {
    height: "50px",
  },
}));
